// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeStreamLocationBlockResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7C69682-7F88-40DD-A198-10D0309E439B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations.</para>
        /// </summary>
        [NameInMap("StreamBlockList")]
        [Validation(Required=false)]
        public DescribeStreamLocationBlockResponseBodyStreamBlockList StreamBlockList { get; set; }
        public class DescribeStreamLocationBlockResponseBodyStreamBlockList : TeaModel {
            [NameInMap("StreamBlock")]
            [Validation(Required=false)]
            public List<DescribeStreamLocationBlockResponseBodyStreamBlockListStreamBlock> StreamBlock { get; set; }
            public class DescribeStreamLocationBlockResponseBodyStreamBlockListStreamBlock : TeaModel {
                /// <summary>
                /// <para>The name of the application in which the blocking applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The blocking type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>blacklist</description></item>
                /// <item><description>whitelist</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>blacklist</para>
                /// </summary>
                [NameInMap("BlockType")]
                [Validation(Required=false)]
                public string BlockType { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The blocked region. If multiple regions are specified, such as CN and AS, they are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("LocationList")]
                [Validation(Required=false)]
                public string LocationList { get; set; }

                /// <summary>
                /// <para>The time when the blocking ends. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-13T09:27Z</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The blocking status. Valid values: 0 (not started), 1 (blocking), 2 (successful), 3 (failed), 4 (expired), and 5 (deleting).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The name of the stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The time when the configuration was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-14T09:27Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
