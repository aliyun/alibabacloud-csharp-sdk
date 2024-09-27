// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonMetadataResponseBody : TeaModel {
        /// <summary>
        /// <para>The component schema parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\n  \&quot;$schema\&quot;: \&quot;<a href="https://json-schema.org/draft-07/schema#%5C%5C%22,%5C%5Cn">https://json-schema.org/draft-07/schema#\\&quot;,\\n</a>  \&quot;properties\&quot;: {\n    \&quot;controller\&quot;: {\n      \&quot;description\&quot;: \&quot;\&quot;,\n      \&quot;properties\&quot;: {\n        \&quot;resources\&quot;: {\n          \&quot;properties\&quot;: {\n            \&quot;armsPrometheusOperator\&quot;: {\n              \&quot;properties\&quot;: {\n                \&quot;resources\&quot;: {\n                  \&quot;properties\&quot;: {\n                    \&quot;limits\&quot;: {\n                      \&quot;properties\&quot;: {\n                        \&quot;memory\&quot;: {\n                          \&quot;description\&quot;: \&quot;memory limit of arms prometheus operator\&quot;,\n                          \&quot;type\&quot;: \&quot;string\&quot;,\n                          \&quot;pattern\&quot;: \&quot;^[1-9][0-9]<em>(\\\\.\\\\d+)?(K|Ki|M|Mi|G|Gi|T|Ti)?$\&quot;,\n                          \&quot;default\&quot;: \&quot;500m\&quot;,\n                          \&quot;x-ui-description\&quot;: \&quot;<mds-key>\&quot;,\n                          \&quot;x-ui-prompt-message\&quot;: \&quot;<mds-key>\&quot;,\n                          \&quot;x-ui-validation-message\&quot;: \&quot;<mds-key>\&quot;,\n                          \&quot;x-ui-additional-tips\&quot;: \&quot;<mds-key>\&quot;\n                        },\n                        \&quot;cpu\&quot;: {\n                          \&quot;description\&quot;: \&quot;cpu limit of arms prometheus operator\&quot;,\n                          \&quot;type\&quot;: \&quot;string\&quot;,\n                          \&quot;pattern\&quot;: \&quot;^[1-9][0-9]</em>(m|\\\\.\\\\d+)?$\&quot;,\n                          \&quot;default\&quot;: \&quot;1.0\&quot;,\n                          \&quot;x-ui-description\&quot;: \&quot;<mds-key>\&quot;,\n                          \&quot;x-ui-validation-message\&quot;: \&quot;<mds-key>\&quot;\n                        }\n                      },\n                      \&quot;type\&quot;: \&quot;object\&quot;,\n                      \&quot;additionalProperties\&quot;: false\n                    },\n                    \&quot;requests\&quot;: {\n                      \&quot;properties\&quot;: {\n                        \&quot;memory\&quot;: {\n                          \&quot;description\&quot;: \&quot;memory request of arms prometheus operator\&quot;,\n                          \&quot;type\&quot;: \&quot;string\&quot;,\n                          \&quot;pattern\&quot;: \&quot;^[1-9][0-9]<em>(\\\\.\\\\d+)?(K|Ki|M|Mi|G|Gi|T|Ti)?$\&quot;,\n                          \&quot;default\&quot;: \&quot;500m\&quot;,\n                          \&quot;x-ui-description\&quot;: \&quot;<mds-key>\&quot;,\n                          \&quot;x-ui-validation-message\&quot;: \&quot;<mds-key>\&quot;\n                        },\n                        \&quot;cpu\&quot;: {\n                          \&quot;description\&quot;: \&quot;cpu request of arms prometheus operator\&quot;,\n                          \&quot;type\&quot;: \&quot;string\&quot;,\n                          \&quot;pattern\&quot;: \&quot;^[1-9][0-9]</em>(m|\\\\.\\\\d+)?$\&quot;,\n                          \&quot;default\&quot;: \&quot;1.0\&quot;,\n                          \&quot;x-ui-description\&quot;: \&quot;<mds-key>\&quot;,\n                          \&quot;x-ui-validation-message\&quot;: \&quot;<mds-key>\&quot;\n                        }\n                      },\n                      \&quot;type\&quot;: \&quot;object\&quot;,\n                      \&quot;additionalProperties\&quot;: false\n                    }\n                  },\n                  \&quot;type\&quot;: \&quot;object\&quot;,\n                  \&quot;additionalProperties\&quot;: false\n                }\n              },\n              \&quot;type\&quot;: \&quot;object\&quot;,\n              \&quot;additionalProperties\&quot;: false\n            }\n          },\n          \&quot;type\&quot;: \&quot;object\&quot;,\n          \&quot;additionalProperties\&quot;: false\n        }\n      },\n      \&quot;type\&quot;: \&quot;object\&quot;,\n      \&quot;additionalProperties\&quot;: false\n    }\n  },\n  \&quot;title\&quot;: \&quot;Values\&quot;,\n  \&quot;type\&quot;: \&quot;object\&quot;,\n  \&quot;additionalProperties\&quot;: false\n}</para>
        /// </summary>
        [NameInMap("config_schema")]
        [Validation(Required=false)]
        public string ConfigSchema { get; set; }

        /// <summary>
        /// <para>The component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coredns</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.8.4.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
