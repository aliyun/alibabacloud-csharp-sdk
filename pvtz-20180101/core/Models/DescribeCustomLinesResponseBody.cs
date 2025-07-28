// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeCustomLinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom lines.</para>
        /// </summary>
        [NameInMap("CustomLines")]
        [Validation(Required=false)]
        public DescribeCustomLinesResponseBodyCustomLines CustomLines { get; set; }
        public class DescribeCustomLinesResponseBodyCustomLines : TeaModel {
            [NameInMap("CustomLine")]
            [Validation(Required=false)]
            public List<DescribeCustomLinesResponseBodyCustomLinesCustomLine> CustomLine { get; set; }
            public class DescribeCustomLinesResponseBodyCustomLinesCustomLine : TeaModel {
                /// <summary>
                /// <para>The time when the custom line was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-25T08:07Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the custom line was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1671174074000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The creator of the custom line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21312421</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The type of the creator for the custom line. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM: Alibaba Cloud account</description></item>
                /// <item><description>SUB: RAM user</description></item>
                /// <item><description>STS: assumed role that obtains the Security Token Service (STS) token of a RAM role</description></item>
                /// <item><description>OTHER: other roles</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUB</para>
                /// </summary>
                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                /// <summary>
                /// <para>The role of the creator for the custom line. Valid values:</para>
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

                [NameInMap("DnsCategory")]
                [Validation(Required=false)]
                public string DnsCategory { get; set; }

                /// <summary>
                /// <para>The IPv4 CIDR blocks.</para>
                /// </summary>
                [NameInMap("Ipv4s")]
                [Validation(Required=false)]
                public DescribeCustomLinesResponseBodyCustomLinesCustomLineIpv4s Ipv4s { get; set; }
                public class DescribeCustomLinesResponseBodyCustomLinesCustomLineIpv4s : TeaModel {
                    [NameInMap("Ipv4")]
                    [Validation(Required=false)]
                    public List<string> Ipv4 { get; set; }

                }

                /// <summary>
                /// <para>The unique ID of the custom line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>160002</para>
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
                /// <para>The time when the custom line was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-24T16:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The time when the custom line was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1681879029000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF7D4DCE-0776-47F2-A9B2-6FB85A87AA60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
