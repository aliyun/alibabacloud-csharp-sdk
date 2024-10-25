// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The edge application template. The value must be a JSON string that contains the following information:</para>
        /// <list type="bullet">
        /// <item><description>Basic information such as the name of the application</description></item>
        /// <item><description>Information such as resource specifications and network security configurations</description></item>
        /// <item><description>Service specifications</description></item>
        /// <item><description>Required resources</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;appMetaData\&quot;:{        \&quot;appName\&quot;:\&quot;nginx\&quot;,        \&quot;clusterName\&quot;:\&quot;poc\&quot;,        \&quot;appType\&quot;:\&quot;Common\&quot;,        \&quot;description\&quot;:\&quot;test\&quot;    },    \&quot;resourceAttribute\&quot;:{        \&quot;resourceType\&quot;:\&quot;\&quot;,        \&quot;instanceSpec\&quot;:\&quot;ens.sn1.tiny\&quot;,        \&quot;systemDiskSize\&quot;:20,        \&quot;dataDiskSize\&quot;:0,        \&quot;bandwithOut\&quot;:10,        \&quot;areaLevel\&quot;:\&quot;National\&quot;,        \&quot;netSecurityStrategy\&quot;:null,        \&quot;initConfig\&quot;:null    },    \&quot;resourceSelector\&quot;:[        {            \&quot;count\&quot;:1        }    ],    \&quot;workload\&quot;:[        {            \&quot;podCount\&quot;:1,            \&quot;serviceConfig\&quot;:null,            \&quot;name\&quot;:\&quot;nginx\&quot;,            \&quot;podSpec\&quot;:{                \&quot;containers\&quot;:[                    {                        \&quot;name\&quot;:\&quot;android\&quot;,                        \&quot;image\&quot;:\&quot;edge-registry.alicdn.com/test/nginx\&quot;                    }                ]            },            \&quot;count\&quot;:1        }    ]}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The timeout period for asynchronous processing. Unit: seconds. Default value: 1800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
