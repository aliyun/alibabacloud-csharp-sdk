// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeCustomLineInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-23T03:15Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The creation timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516775741000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260282302749096109</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The subtype of the creator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CUSTOM</c>: Alibaba Cloud account</para>
        /// </description></item>
        /// <item><description><para><c>SUB</c>: RAM user</para>
        /// </description></item>
        /// <item><description><para><c>STS</c>: assumed role</para>
        /// </description></item>
        /// <item><description><para><c>OTHER</c>: other roles</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("CreatorSubType")]
        [Validation(Required=false)]
        public string CreatorSubType { get; set; }

        /// <summary>
        /// <para>The creator type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>USER</c>: user</para>
        /// </description></item>
        /// <item><description><para><c>SYSTEM</c>: system</para>
        /// </description></item>
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
        /// <para>A list of IPv4 address segments.</para>
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
        /// <para>The custom line name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
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
        /// <para>The last update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-24T06:35Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The last update timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516775741000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
