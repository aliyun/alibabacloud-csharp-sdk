// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RestoreMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the media asset that failed to be processed.</para>
        /// </summary>
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public RestoreMediaResponseBodyForbiddenList ForbiddenList { get; set; }
        public class RestoreMediaResponseBodyForbiddenList : TeaModel {
            [NameInMap("MediaForbiddenReasonDTO")]
            [Validation(Required=false)]
            public List<RestoreMediaResponseBodyForbiddenListMediaForbiddenReasonDTO> MediaForbiddenReasonDTO { get; set; }
            public class RestoreMediaResponseBodyForbiddenListMediaForbiddenReasonDTO : TeaModel {
                /// <summary>
                /// <para>The ID of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fa10ee70898671edb99f6eb3690d****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The reason for the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Forbidden.RestoreMedia</para>
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
        public RestoreMediaResponseBodyIgnoredList IgnoredList { get; set; }
        public class RestoreMediaResponseBodyIgnoredList : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E70E3F8-E2EE-47BC-4677-379D6F28****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
