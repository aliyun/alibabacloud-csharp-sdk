// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeWhitelistSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination parameter: current page number, default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of certification details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeWhitelistSettingResponseBodyItems> Items { get; set; }
        public class DescribeWhitelistSettingResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Certificate number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>320321XXXXXXXX701X</para>
            /// </summary>
            [NameInMap("CertNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>Certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shad861465f2aaeeb805b519e1a93ab2</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16 17:28:03</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16 17:28:03</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Whitelist ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6372003</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试白名单</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000332</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>Whitelist status:</para>
            /// <list type="bullet">
            /// <item><description><b>VALID</b>: Valid.</description></item>
            /// <item><description><b>INVALID</b>: Invalid.</description></item>
            /// <item><description><b>DELETED</b>: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Effective end date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16 17:28:03</para>
            /// </summary>
            [NameInMap("ValidEndDate")]
            [Validation(Required=false)]
            public string ValidEndDate { get; set; }

            /// <summary>
            /// <para>Effective start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16 17:28:03</para>
            /// </summary>
            [NameInMap("ValidStartDate")]
            [Validation(Required=false)]
            public string ValidStartDate { get; set; }

        }

        /// <summary>
        /// <para>Number of items per page for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B8ACFD2-C5F0-5F9F-8DD4-E44F93E360E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
