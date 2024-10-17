// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitivityLevelResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E1D2B4D-3E53-4ABC-999D-1D2520B3471A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sensitivity levels.</para>
        /// </summary>
        [NameInMap("SensitivityLevelList")]
        [Validation(Required=false)]
        public List<ListSensitivityLevelResponseBodySensitivityLevelList> SensitivityLevelList { get; set; }
        public class ListSensitivityLevelResponseBodySensitivityLevelList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the fields of the sensitive level are displayed in plaintext.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPlain")]
            [Validation(Required=false)]
            public bool? IsPlain { get; set; }

            /// <summary>
            /// <para>The name of the sensitive level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the classification template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1070</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the classification template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INNER</b>: a built-in template.</description></item>
            /// <item><description><b>USER_DEFINE</b>: a custom template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INNER</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
