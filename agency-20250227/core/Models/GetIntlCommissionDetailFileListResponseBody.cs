// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetIntlCommissionDetailFileListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIntlCommissionDetailFileListResponseBodyData Data { get; set; }
        public class GetIntlCommissionDetailFileListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The billing month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202502</para>
            /// </summary>
            [NameInMap("BillMonth")]
            [Validation(Required=false)]
            public string BillMonth { get; set; }

            /// <summary>
            /// <para>The file list object.</para>
            /// </summary>
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<GetIntlCommissionDetailFileListResponseBodyDataFileList> FileList { get; set; }
            public class GetIntlCommissionDetailFileListResponseBodyDataFileList : TeaModel {
                /// <summary>
                /// <para>The push status of the OSS file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>初始化状态: initialization status</description></item>
                /// <item><description>处理中: processing</description></item>
                /// <item><description>处理成功: processing succeeded</description></item>
                /// <item><description>处理失败: processing failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>处理中</para>
                /// </summary>
                [NameInMap("BucketSyncStatus")]
                [Validation(Required=false)]
                public string BucketSyncStatus { get; set; }

                /// <summary>
                /// <para>The commission policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>参考【APS佣金查询下载功能】的政策名称</para>
                /// </summary>
                [NameInMap("CommissionPolicyName")]
                [Validation(Required=false)]
                public string CommissionPolicyName { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202606_FY27_TEST_4397912340.xlsx</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>The UID of the partner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1112332432</para>
            /// </summary>
            [NameInMap("PartnerUid")]
            [Validation(Required=false)]
            public string PartnerUid { get; set; }

        }

        /// <summary>
        /// <para>The message information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a30617045934095083027d88c5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
