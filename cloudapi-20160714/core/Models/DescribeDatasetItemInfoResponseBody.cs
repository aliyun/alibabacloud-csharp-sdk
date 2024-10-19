// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDatasetItemInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The Dataset information.</para>
        /// </summary>
        [NameInMap("DatasetItemInfo")]
        [Validation(Required=false)]
        public DescribeDatasetItemInfoResponseBodyDatasetItemInfo DatasetItemInfo { get; set; }
        public class DescribeDatasetItemInfoResponseBodyDatasetItemInfo : TeaModel {
            /// <summary>
            /// <para>The creation time (UTC) of the data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-21T12:58:43Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>626238665db4a5140eea3e40********</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The ID of the data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5045****</para>
            /// </summary>
            [NameInMap("DatasetItemId")]
            [Validation(Required=false)]
            public string DatasetItemId { get; set; }

            /// <summary>
            /// <para>The description of the data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time in UTC when the data entry expires. The time is in the <b>yyyy-MM-ddTHH:mm:ssZ</b> format. If this parameter is empty, the data entry does not expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-22T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The last modification time (UTC) of the data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-21T12:58:43Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The value of the data entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>106.43.XXX.XXX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BAFA85F-38E3-5D9E-9E32-4B09********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
