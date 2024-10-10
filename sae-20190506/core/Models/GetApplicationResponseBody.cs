// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetApplicationResponseBody : TeaModel {
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443d638a-ef76-47c4-b707-61197d******</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ee99cce6-1c8e-4bfa-96c3-3e2fa9******</para>
            /// </summary>
            [NameInMap("BaseAppId")]
            [Validation(Required=false)]
            public string BaseAppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-8ps2o182102o1jv05bys</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public int? Instances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MseEnabled")]
            [Validation(Required=false)]
            public bool? MseEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MseNamespaceId")]
            [Validation(Required=false)]
            public string MseNamespaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java</para>
            /// </summary>
            [NameInMap("ProgrammingLanguage")]
            [Validation(Required=false)]
            public string ProgrammingLanguage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public string ScaleRuleEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>timing</para>
            /// </summary>
            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01CF26C7-00A3-4AA6-BA76-7E95F2A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ac1a0b2215622920113732501e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
