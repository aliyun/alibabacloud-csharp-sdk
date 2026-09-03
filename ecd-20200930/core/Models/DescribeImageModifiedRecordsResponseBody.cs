// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImageModifiedRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The image change records.</para>
        /// </summary>
        [NameInMap("ImageModifiedRecords")]
        [Validation(Required=false)]
        public List<DescribeImageModifiedRecordsResponseBodyImageModifiedRecords> ImageModifiedRecords { get; set; }
        public class DescribeImageModifiedRecordsResponseBodyImageModifiedRecords : TeaModel {
            /// <summary>
            /// <para>The image ID before the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desktopimage-windows-server-2019-64-ch-asp</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name before the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows server 2019 Mainland</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The ID of the new image after the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desktopimage-windows-server-2022-64-ch-asp</para>
            /// </summary>
            [NameInMap("NewImageId")]
            [Validation(Required=false)]
            public string NewImageId { get; set; }

            /// <summary>
            /// <para>The name of the new image after the change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows server 2022 Mainland asp</para>
            /// </summary>
            [NameInMap("NewImageName")]
            [Validation(Required=false)]
            public string NewImageName { get; set; }

            /// <summary>
            /// <para>The reason for ignoring the vulnerability. This parameter is required only when you perform the ignore vulnerability operation, that is, when <c>OperateType</c> is set to <c>vul_ignore</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Defer fix</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the image change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the image was last changed. The time is in the ISO 8601 standard in UTC: yyyy-MM-ddTHH:mm:ss.SSSZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-03T02:43:44.851Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The pagination token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6koN7RqHg3d2z8LKmSoe821</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC40EE61-7E83-59ED-AEA6-7EE9C437F352</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of image change records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
