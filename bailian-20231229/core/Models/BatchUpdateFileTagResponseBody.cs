// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class BatchUpdateFileTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchUpdateFileTagResponseBodyData Data { get; set; }
        public class BatchUpdateFileTagResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of the tag update results.</para>
            /// </summary>
            [NameInMap("UpdateFileTagResultList")]
            [Validation(Required=false)]
            public List<BatchUpdateFileTagResponseBodyDataUpdateFileTagResultList> UpdateFileTagResultList { get; set; }
            public class BatchUpdateFileTagResponseBodyDataUpdateFileTagResultList : TeaModel {
                /// <summary>
                /// <para>The error code. This parameter is returned only if Success is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoPermission</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message. This parameter is returned only if Success is false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FileId not exists.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_f40f2a32205d44b4a93b11617113da15_10045951</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>Indicates whether the tags for the specific file were updated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The tags were updated successfully.</para>
                /// </description></item>
                /// <item><description><para>false: The tag update failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Required parameter(FileId) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was accepted. Check <c>UpdateFileTagResultList</c> for the status of each file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was accepted.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed, for example, due to an invalid parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
