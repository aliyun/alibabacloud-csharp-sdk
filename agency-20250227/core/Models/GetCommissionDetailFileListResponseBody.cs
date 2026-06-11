// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class GetCommissionDetailFileListResponseBody : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCommissionDetailFileListResponseBodyData Data { get; set; }
        public class GetCommissionDetailFileListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Bill month</para>
            /// 
            /// <b>Example:</b>
            /// <para>202502</para>
            /// </summary>
            [NameInMap("BillMonth")]
            [Validation(Required=false)]
            public string BillMonth { get; set; }

            /// <summary>
            /// <para>File list</para>
            /// </summary>
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<GetCommissionDetailFileListResponseBodyDataFileList> FileList { get; set; }
            public class GetCommissionDetailFileListResponseBodyDataFileList : TeaModel {
                /// <summary>
                /// <para>OSS file push status: Processing, Succeeded, or failed</para>
                /// 
                /// <b>Example:</b>
                /// <para>处理中</para>
                /// </summary>
                [NameInMap("BucketSyncStatus")]
                [Validation(Required=false)]
                public string BucketSyncStatus { get; set; }

                /// <summary>
                /// <para>Policy name</para>
                /// 
                /// <b>Example:</b>
                /// <para>参考【APS佣金查询下载功能】的政策名称</para>
                /// </summary>
                [NameInMap("CommissionPolicyName")]
                [Validation(Required=false)]
                public string CommissionPolicyName { get; set; }

                /// <summary>
                /// <para>File name</para>
                /// 
                /// <b>Example:</b>
                /// <para>佣金202502021112</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>File type</para>
                /// 
                /// <b>Example:</b>
                /// <para>总代政策为拓渠、普通政策为拓客</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>File URL</para>
                /// 
                /// <b>Example:</b>
                /// <para>aps.ailyun.com/file/download?resourceId=1234&amp;type=1</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

            }

            /// <summary>
            /// <para>Partner UID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1112332432</para>
            /// </summary>
            [NameInMap("PartnerUid")]
            [Validation(Required=false)]
            public string PartnerUid { get; set; }

        }

        /// <summary>
        /// <para>Message</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the invocation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
