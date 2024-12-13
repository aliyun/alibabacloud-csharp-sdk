// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The new description of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a user.</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The new display name of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliceLee</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// <para>The new email address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:AliceLee@example.com">AliceLee@example.com</a></para>
        /// </summary>
        [NameInMap("NewEmail")]
        [Validation(Required=false)]
        public string NewEmail { get; set; }

        /// <summary>
        /// <para>The new first name of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("NewFirstName")]
        [Validation(Required=false)]
        public string NewFirstName { get; set; }

        /// <summary>
        /// <para>The new last name of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lee</para>
        /// </summary>
        [NameInMap("NewLastName")]
        [Validation(Required=false)]
        public string NewLastName { get; set; }

        /// <summary>
        /// <para>The ID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
