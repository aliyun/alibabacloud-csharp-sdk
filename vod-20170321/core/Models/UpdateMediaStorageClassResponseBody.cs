// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the media assets that failed to be processed.</para>
        /// </summary>
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public UpdateMediaStorageClassResponseBodyForbiddenList ForbiddenList { get; set; }
        public class UpdateMediaStorageClassResponseBodyForbiddenList : TeaModel {
            [NameInMap("MediaForbiddenReasonDTO")]
            [Validation(Required=false)]
            public List<UpdateMediaStorageClassResponseBodyForbiddenListMediaForbiddenReasonDTO> MediaForbiddenReasonDTO { get; set; }
            public class UpdateMediaStorageClassResponseBodyForbiddenListMediaForbiddenReasonDTO : TeaModel {
                /// <summary>
                /// <para>The ID of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19e231ee6e3e417fbf2e92ec2680****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The reason for the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TargetStorageClassInconsistent</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

        }

        /// <summary>
        /// <para>The IDs of the media assets that failed to be obtained.</para>
        /// </summary>
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public UpdateMediaStorageClassResponseBodyIgnoredList IgnoredList { get; set; }
        public class UpdateMediaStorageClassResponseBodyIgnoredList : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30FA0B7C-3A81-5449-93CD-ACA149E6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Processing</b></description></item>
        /// <item><description><b>Failed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Processing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
