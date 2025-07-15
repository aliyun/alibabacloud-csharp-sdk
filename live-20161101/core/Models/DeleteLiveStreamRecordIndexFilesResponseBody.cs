// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteLiveStreamRecordIndexFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A return value of 500 indicates an error. For details, see the Error codes section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status description. A return value of 500 indicates an error. For details, see the Error codes section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The deletion information.</para>
        /// </summary>
        [NameInMap("RecordDeleteInfoList")]
        [Validation(Required=false)]
        public DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoList RecordDeleteInfoList { get; set; }
        public class DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoList : TeaModel {
            [NameInMap("RecordDeleteInfo")]
            [Validation(Required=false)]
            public List<DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoListRecordDeleteInfo> RecordDeleteInfo { get; set; }
            public class DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoListRecordDeleteInfo : TeaModel {
                /// <summary>
                /// <para>The processing result of each file indicated by the file ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The file has been deleted.</description></item>
                /// <item><description><b>AccessDenied</b>: Access to the file has been denied.</description></item>
                /// <item><description><b>FileNotFound</b>: The file fails to be found.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the index file that is used to locate the live stream recording files to be deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c4d7f0a4-b506-43f9-8de3-07732c3f**</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>939D19EE-59A0-18E9-B458-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
