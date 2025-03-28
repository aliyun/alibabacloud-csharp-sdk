// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateStatus : TeaModel {
        [NameInMap("latestDeployment")]
        [Validation(Required=false)]
        public TemplateStatusLatestDeployment LatestDeployment { get; set; }
        public class TemplateStatusLatestDeployment : TeaModel {
            [NameInMap("finishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BuildFinished</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            [NameInMap("pipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("latestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

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
        /// <para><a href="https://cap.console.aliyun.com/template-detail?template=adasdasdaewe-adadqwe">https://cap.console.aliyun.com/template-detail?template=adasdasdaewe-adadqwe</a></para>
        /// </summary>
        [NameInMap("templateUrl")]
        [Validation(Required=false)]
        public string TemplateUrl { get; set; }

    }

}
