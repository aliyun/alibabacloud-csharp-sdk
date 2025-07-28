// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class SearchCustomLinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom lines.</para>
        /// </summary>
        [NameInMap("CustomLines")]
        [Validation(Required=false)]
        public SearchCustomLinesResponseBodyCustomLines CustomLines { get; set; }
        public class SearchCustomLinesResponseBodyCustomLines : TeaModel {
            [NameInMap("CustomLine")]
            [Validation(Required=false)]
            public List<SearchCustomLinesResponseBodyCustomLinesCustomLine> CustomLine { get; set; }
            public class SearchCustomLinesResponseBodyCustomLinesCustomLine : TeaModel {
                /// <summary>
                /// <para>The time when the custom line was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-27 18:16:38</para>
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
                /// <para>The ID of the creator for the custom line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1851321989648462</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creator type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM: Alibaba Cloud account</description></item>
                /// <item><description>SUB: RAM user</description></item>
                /// <item><description>STS: assumed role that obtains the Security Token Service (STS) token of a RAM role</description></item>
                /// <item><description>OTHER: other types</description></item>
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
                public SearchCustomLinesResponseBodyCustomLinesCustomLineIpv4s Ipv4s { get; set; }
                public class SearchCustomLinesResponseBodyCustomLinesCustomLineIpv4s : TeaModel {
                    [NameInMap("Ipv4")]
                    [Validation(Required=false)]
                    public List<string> Ipv4 { get; set; }

                }

                /// <summary>
                /// <para>The unique ID of the custom line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11730</para>
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
                /// <para>The time when the custom line was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-14 14:04:08</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The time when the custom line was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672136518000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
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
        /// <para>46973D4C-E3E4-4ABA-9190-9A9DE406C7E</para>
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
