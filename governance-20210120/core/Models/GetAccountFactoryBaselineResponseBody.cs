// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetAccountFactoryBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The baseline ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afb-bp16ae2k8a3yo3d*****</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// <para>The baseline items.</para>
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<GetAccountFactoryBaselineResponseBodyBaselineItems> BaselineItems { get; set; }
        public class GetAccountFactoryBaselineResponseBodyBaselineItems : TeaModel {
            /// <summary>
            /// <para>The configuration of the baseline item.</para>
            /// <para>The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Notifications\&quot;:[{\&quot;GroupKey\&quot;:\&quot;account_msg\&quot;,\&quot;Contacts\&quot;:[{\&quot;Name\&quot;:\&quot;aa\&quot;}],\&quot;PmsgStatus\&quot;:1,\&quot;EmailStatus\&quot;:1,\&quot;SmsStatus\&quot;:1}]}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The name of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1097526274671790</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The name of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("BaselineName")]
        [Validation(Required=false)]
        public string BaselineName { get; set; }

        /// <summary>
        /// <para>The time when the baseline was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-28T00:46:34Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default baseline</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60D54503-F1F6-51B6-B6FA-A70CBDA2A68C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the baseline. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>System: default baseline.</description></item>
        /// <item><description>Custom: custom baseline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the baseline was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-02T01:00:07Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
