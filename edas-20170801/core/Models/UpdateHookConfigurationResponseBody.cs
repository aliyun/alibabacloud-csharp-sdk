// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateHookConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the mounted script.</para>
        /// </summary>
        [NameInMap("HooksConfiguration")]
        [Validation(Required=false)]
        public List<UpdateHookConfigurationResponseBodyHooksConfiguration> HooksConfiguration { get; set; }
        public class UpdateHookConfigurationResponseBodyHooksConfiguration : TeaModel {
            /// <summary>
            /// <para>Indicates whether a mount failure is ignored. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A mount failure is ignored.</description></item>
            /// <item><description><b>false</b>: A mount failure is not ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IgnoreFail")]
            [Validation(Required=false)]
            public bool? IgnoreFail { get; set; }

            /// <summary>
            /// <para>The name of the mounted script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postprepareInstanceEnvironmentOnScaleOut</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The content of the mounted script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ls</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d498****-1dd8ec229862</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
