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

        [NameInMap("RecordDeleteInfoList")]
        [Validation(Required=false)]
        public DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoList RecordDeleteInfoList { get; set; }
        public class DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoList : TeaModel {
            [NameInMap("RecordDeleteInfo")]
            [Validation(Required=false)]
            public List<DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoListRecordDeleteInfo> RecordDeleteInfo { get; set; }
            public class DeleteLiveStreamRecordIndexFilesResponseBodyRecordDeleteInfoListRecordDeleteInfo : TeaModel {
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

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
