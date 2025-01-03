// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkitemAttachmentsResponseBody : TeaModel {
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<ListWorkitemAttachmentsResponseBodyAttachments> Attachments { get; set; }
        public class ListWorkitemAttachmentsResponseBodyAttachments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>237109</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dflkjlsdddsdl234lkjfg</para>
            /// </summary>
            [NameInMap("fileIdentifier")]
            [Validation(Required=false)]
            public string FileIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Artifacts_1565193_1.tgz</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tgz</para>
            /// </summary>
            [NameInMap("fileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1545726028000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://grace-share.oss-cn-hangzhou.aliyuncs.com/qf%2Fheap.bin?Expires=1675750082&OSSAccessKeyId=LTAI5t8irN2Wu3BGrBpffZue&Signature=RqRUEuHiwW8wuahYz6CenHaWWs4%3D">http://grace-share.oss-cn-hangzhou.aliyuncs.com/qf%2Fheap.bin?Expires=1675750082&amp;OSSAccessKeyId=LTAI5t8irN2Wu3BGrBpffZue&amp;Signature=RqRUEuHiwW8wuahYz6CenHaWWs4%3D</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7B85D1B-D1C2-140F-A039-341859F130B9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
