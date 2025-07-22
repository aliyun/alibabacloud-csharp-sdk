// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDriveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1202****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dom-aaaa****</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("DriveName")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234****</para>
        /// </summary>
        [NameInMap("ExternalDomainId")]
        [Validation(Required=false)]
        public string ExternalDomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ProfileRoaming")]
        [Validation(Required=false)]
        public bool? ProfileRoaming { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NAS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER_PROFILE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
