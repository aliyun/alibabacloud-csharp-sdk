// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSimilarEventScenariosResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDF7B8D9-8493-4B90-8D13-E0C1FFCE5F97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of handling scenarios for alerts of the same type.</para>
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public List<DescribeSimilarEventScenariosResponseBodyScenarios> Scenarios { get; set; }
        public class DescribeSimilarEventScenariosResponseBodyScenarios : TeaModel {
            /// <summary>
            /// <para>The code of the handling scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: same alerting type</description></item>
            /// <item><description><b>same_file_content</b>: same file content rule</description></item>
            /// <item><description><b>same_ip</b>: same IP rule</description></item>
            /// <item><description><b>same_url</b>: same URL rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>same_url</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

        }

    }

}
