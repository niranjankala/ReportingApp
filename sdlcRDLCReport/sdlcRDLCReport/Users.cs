//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sdlcRDLCReport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.KMClosedDiscussion = new HashSet<KMClosedDiscussion>();
            this.KMClosedDiscussion1 = new HashSet<KMClosedDiscussion>();
            this.KMComments = new HashSet<KMComments>();
            this.KMComments1 = new HashSet<KMComments>();
            this.KMDocuments = new HashSet<KMDocuments>();
            this.KMDocuments1 = new HashSet<KMDocuments>();
            this.KMEmailNotification = new HashSet<KMEmailNotification>();
            this.KMEmailNotification1 = new HashSet<KMEmailNotification>();
            this.KMFollowingMessage = new HashSet<KMFollowingMessage>();
            this.KMFollowingMessage1 = new HashSet<KMFollowingMessage>();
            this.KMFollowingMessage2 = new HashSet<KMFollowingMessage>();
            this.KMFollowingUser = new HashSet<KMFollowingUser>();
            this.KMFollowingUser1 = new HashSet<KMFollowingUser>();
            this.KMFollowingUser2 = new HashSet<KMFollowingUser>();
            this.KMFollowingUser3 = new HashSet<KMFollowingUser>();
            this.KMGroupMembers = new HashSet<KMGroupMembers>();
            this.KMGroupMembers1 = new HashSet<KMGroupMembers>();
            this.KMGroupMembers2 = new HashSet<KMGroupMembers>();
            this.KMGroups = new HashSet<KMGroups>();
            this.KMGroups1 = new HashSet<KMGroups>();
            this.KMLikeMessage = new HashSet<KMLikeMessage>();
            this.KMLikeMessage1 = new HashSet<KMLikeMessage>();
            this.KMLikeMessage2 = new HashSet<KMLikeMessage>();
            this.KMMessageTag = new HashSet<KMMessageTag>();
            this.KMMessageTag1 = new HashSet<KMMessageTag>();
            this.KMNotifications = new HashSet<KMNotifications>();
            this.KMNotifications1 = new HashSet<KMNotifications>();
            this.KMSubDocuments = new HashSet<KMSubDocuments>();
            this.KMSubDocuments1 = new HashSet<KMSubDocuments>();
            this.KMTags = new HashSet<KMTags>();
            this.KMTags1 = new HashSet<KMTags>();
            this.KMUserCredits = new HashSet<KMUserCredits>();
            this.KMUserEmailNotification = new HashSet<KMUserEmailNotification>();
            this.KMUserEmailNotification1 = new HashSet<KMUserEmailNotification>();
            this.KMUserEmailNotification2 = new HashSet<KMUserEmailNotification>();
            this.KMWarranty = new HashSet<KMWarranty>();
            this.KMWarranty1 = new HashSet<KMWarranty>();
            this.Roles = new HashSet<Roles>();
        }
    
        public System.Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsAnonymous { get; set; }
        public int PasswordFailuresSinceLastSuccess { get; set; }
        public Nullable<System.DateTime> LastPasswordFailureDate { get; set; }
        public string ConfirmationToken { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> PasswordChangedDate { get; set; }
        public string PasswordVerificationToken { get; set; }
        public Nullable<System.DateTime> PasswordVerificationTokenExpirationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TimeZone { get; set; }
        public string Culture { get; set; }
        public string AboutMe { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string WorkTitle { get; set; }
        public Nullable<System.Guid> PlantId { get; set; }
        public string Mobile { get; set; }
        public string WorkPhone { get; set; }
        public string UserAvatar { get; set; }
    
        public virtual ICollection<KMClosedDiscussion> KMClosedDiscussion { get; set; }
        public virtual ICollection<KMClosedDiscussion> KMClosedDiscussion1 { get; set; }
        public virtual ICollection<KMComments> KMComments { get; set; }
        public virtual ICollection<KMComments> KMComments1 { get; set; }
        public virtual ICollection<KMDocuments> KMDocuments { get; set; }
        public virtual ICollection<KMDocuments> KMDocuments1 { get; set; }
        public virtual ICollection<KMEmailNotification> KMEmailNotification { get; set; }
        public virtual ICollection<KMEmailNotification> KMEmailNotification1 { get; set; }
        public virtual ICollection<KMFollowingMessage> KMFollowingMessage { get; set; }
        public virtual ICollection<KMFollowingMessage> KMFollowingMessage1 { get; set; }
        public virtual ICollection<KMFollowingMessage> KMFollowingMessage2 { get; set; }
        public virtual ICollection<KMFollowingUser> KMFollowingUser { get; set; }
        public virtual ICollection<KMFollowingUser> KMFollowingUser1 { get; set; }
        public virtual ICollection<KMFollowingUser> KMFollowingUser2 { get; set; }
        public virtual ICollection<KMFollowingUser> KMFollowingUser3 { get; set; }
        public virtual ICollection<KMGroupMembers> KMGroupMembers { get; set; }
        public virtual ICollection<KMGroupMembers> KMGroupMembers1 { get; set; }
        public virtual ICollection<KMGroupMembers> KMGroupMembers2 { get; set; }
        public virtual ICollection<KMGroups> KMGroups { get; set; }
        public virtual ICollection<KMGroups> KMGroups1 { get; set; }
        public virtual ICollection<KMLikeMessage> KMLikeMessage { get; set; }
        public virtual ICollection<KMLikeMessage> KMLikeMessage1 { get; set; }
        public virtual ICollection<KMLikeMessage> KMLikeMessage2 { get; set; }
        public virtual ICollection<KMMessageTag> KMMessageTag { get; set; }
        public virtual ICollection<KMMessageTag> KMMessageTag1 { get; set; }
        public virtual ICollection<KMNotifications> KMNotifications { get; set; }
        public virtual ICollection<KMNotifications> KMNotifications1 { get; set; }
        public virtual KMPlant KMPlant { get; set; }
        public virtual ICollection<KMSubDocuments> KMSubDocuments { get; set; }
        public virtual ICollection<KMSubDocuments> KMSubDocuments1 { get; set; }
        public virtual ICollection<KMTags> KMTags { get; set; }
        public virtual ICollection<KMTags> KMTags1 { get; set; }
        public virtual ICollection<KMUserCredits> KMUserCredits { get; set; }
        public virtual ICollection<KMUserEmailNotification> KMUserEmailNotification { get; set; }
        public virtual ICollection<KMUserEmailNotification> KMUserEmailNotification1 { get; set; }
        public virtual ICollection<KMUserEmailNotification> KMUserEmailNotification2 { get; set; }
        public virtual ICollection<KMWarranty> KMWarranty { get; set; }
        public virtual ICollection<KMWarranty> KMWarranty1 { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
    }
}