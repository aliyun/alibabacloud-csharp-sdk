// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeCustomLineInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the custom line was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-23T03:15Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the custom line was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516775741000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The creator of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260282302749096109</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The type of the creator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CUSTOM: Alibaba Cloud account</description></item>
        /// <item><description>SUB: RAM user</description></item>
        /// <item><description>STS: assumed role that obtains the Security Token Service (STS) token of a RAM role</description></item>
        /// <item><description>OTHER: other roles</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("CreatorSubType")]
        [Validation(Required=false)]
        public string CreatorSubType { get; set; }

        /// <summary>
        /// <para>The role of the creator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: user</description></item>
        /// <item><description>SYSTEM: system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("CreatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        [NameInMap("Dnscategory")]
        [Validation(Required=false)]
        public string Dnscategory { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR blocks.</para>
        /// </summary>
        [NameInMap("Ipv4s")]
        [Validation(Required=false)]
        public List<string> Ipv4s { get; set; }

        /// <summary>
        /// <para>The unique ID of the custom line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100003</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public string LineId { get; set; }

        /// <summary>
        /// <para>The name of the custom line.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B7AD377-7E86-44A8-B9A8-53E8666E72FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the custom line was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-24T06:35Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the custom line was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516775741000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
