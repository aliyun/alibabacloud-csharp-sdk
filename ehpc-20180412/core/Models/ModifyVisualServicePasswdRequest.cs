// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyVisualServicePasswdRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The connection password of the VNC remote visualization service. The password must be 8 to 30 characters in length and include at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:
        /// 
        /// `()~! @#$%^&*-_+=|{}[]:;\"/<>,.? /`
        /// 
        /// >  You must use HTTPS to call the API to ensure that the password remains confidential.
        /// </summary>
        [NameInMap("Passwd")]
        [Validation(Required=false)]
        public string Passwd { get; set; }

        /// <summary>
        /// The username of the cluster. Default value: root user. You can call the [ListUsers](~~188572~~) operation to query all users in a cluster.
        /// </summary>
        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        /// <summary>
        /// The user password of the cluster.
        /// </summary>
        [NameInMap("RunasUserPassword")]
        [Validation(Required=false)]
        public string RunasUserPassword { get; set; }

    }

}
