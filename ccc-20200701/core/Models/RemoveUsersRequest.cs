// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RemoveUsersRequest : TeaModel {
        /// <summary>
        /// <para>The ObjectKey of the OSS object containing the file with the list of users to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp/removeUsers.xlsx</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>Specifies whether to force delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Notification email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:123@abc.com">123@abc.com</a></para>
        /// </summary>
        [NameInMap("NotificationEmail")]
        [Validation(Required=false)]
        public string NotificationEmail { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string representing an array of agent IDs. Each array element is an agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;agent1@ccc-test&quot;,&quot;agent2@ccc-test&quot;]</para>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

    }

}
