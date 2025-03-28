// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateRevision : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-11-19T09:34:38Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>It is a template revision</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TemplateRevision</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-template</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("spec")]
        [Validation(Required=false)]
        public TemplateSpec Spec { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public TemplateRevisionStatus Status { get; set; }
        public class TemplateRevisionStatus : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://registry.serverless-devs.com/details.html?name=template-test&package_type=v3">https://registry.serverless-devs.com/details.html?name=template-test&amp;package_type=v3</a></para>
            /// </summary>
            [NameInMap("packageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Published</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-default</para>
            /// </summary>
            [NameInMap("pipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://cap.console.aliyun.com/template-detail?template=adasdasdaewe-adadqwe">https://cap.console.aliyun.com/template-detail?template=adasdasdaewe-adadqwe</a></para>
            /// </summary>
            [NameInMap("templateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-template</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1455541096***548</para>
        /// </summary>
        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
