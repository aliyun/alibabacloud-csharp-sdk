// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTriggerResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CA76D52-A8F0-4D0B-854E-FBD9F6C99049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The triggers of the repository.</para>
        /// </summary>
        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<ListRepoTriggerResponseBodyTriggers> Triggers { get; set; }
        public class ListRepoTriggerResponseBodyTriggers : TeaModel {
            /// <summary>
            /// <para>The type of the event that activates the trigger. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>BUILD_SUCCESS</c>: The trigger is activated when an image building task is successful.</description></item>
            /// <item><description><c>BUILD_Fail</c>: The trigger is activated when an image building task fails.</description></item>
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
            /// <para>The image tag based on which the trigger is set.</para>
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
            /// <para>The type of the trigger. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ALL</c>: a trigger that supports both tags and regular expressions.</description></item>
            /// <item><description><c>TAG_LISTTAG</c>: a tag-based trigger.</description></item>
            /// <item><description><c>TAG_REG_EXP</c>: a regular expression-based trigger.</description></item>
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
