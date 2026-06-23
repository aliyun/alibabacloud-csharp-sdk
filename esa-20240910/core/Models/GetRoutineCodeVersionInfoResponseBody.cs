// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineCodeVersionInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The build ID of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26035169</para>
        /// </summary>
        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public long? BuildId { get; set; }

        /// <summary>
        /// <para>The description of the code version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code desc version unstable</para>
        /// </summary>
        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// <para>The code version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710120201067203242</para>
        /// </summary>
        [NameInMap("CodeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        /// <summary>
        /// <para>The list of configuration items for the code version.</para>
        /// </summary>
        [NameInMap("ConfOptions")]
        [Validation(Required=false)]
        public GetRoutineCodeVersionInfoResponseBodyConfOptions ConfOptions { get; set; }
        public class GetRoutineCodeVersionInfoResponseBodyConfOptions : TeaModel {
            /// <summary>
            /// <para>The NotFoundStrategy configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SinglePageApplication</para>
            /// </summary>
            [NameInMap("NotFoundStrategy")]
            [Validation(Required=false)]
            public string NotFoundStrategy { get; set; }

        }

        /// <summary>
        /// <para>The time when the code version was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-04T01:54:19Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The additional information about the code version. The value is in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>Indicates whether the code version contains asset files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAssets")]
        [Validation(Required=false)]
        public bool? HasAssets { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the code version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
