// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTriggerResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The API call was successful.</description></item>
        /// <item><description><c>false</c>: The API call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CA76D52-A8F0-4D0B-854E-FBD9F6C99049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of triggers.</para>
        /// </summary>
        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<ListRepoTriggerResponseBodyTriggers> Triggers { get; set; }
        public class ListRepoTriggerResponseBodyTriggers : TeaModel {
            /// <summary>
            /// <para>The event type of the trigger. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>BUILD_SUCCESS</c>: The trigger was successful.</description></item>
            /// <item><description><c>BUILD_Fail</c>: The trigger failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUILD_SUCCESS</para>
            /// </summary>
            [NameInMap("RepoEvent")]
            [Validation(Required=false)]
            public string RepoEvent { get; set; }

            /// <summary>
            /// <para>The ID of the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crw-vriyql9eq7ep****</para>
            /// </summary>
            [NameInMap("TriggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            /// <summary>
            /// <para>The name of the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TriggerName")]
            [Validation(Required=false)]
            public string TriggerName { get; set; }

            /// <summary>
            /// <para>The image version that triggers the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("TriggerTag")]
            [Validation(Required=false)]
            public string TriggerTag { get; set; }

            /// <summary>
            /// <para>The trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ALL</c>: All.</description></item>
            /// <item><description><c>TAG_LISTTAG</c>: Tag list.</description></item>
            /// <item><description><c>TAG_REG_EXP</c>: Regular expression.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The URL of the trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.test.com">https://www.test.com</a></para>
            /// </summary>
            [NameInMap("TriggerUrl")]
            [Validation(Required=false)]
            public string TriggerUrl { get; set; }

        }

    }

}
