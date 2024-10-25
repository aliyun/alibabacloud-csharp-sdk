// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UpgradeApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2bac6f4-75dc-455e-8389-2dc8e47526d3</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The information template for phased update. The value must be a JSON string and contain the following information:</para>
        /// <list type="bullet">
        /// <item><description>Version range that you want to update</description></item>
        /// <item><description>Configuration information of the target version</description></item>
        /// <item><description>Canary release policy for resources</description></item>
        /// <item><description>Intelligent upgrade policy that contains information such as the time window and resource usage limit</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;fromAppVersions\&quot;:{        \&quot;operator\&quot;:\&quot;In\&quot;,        \&quot;values\&quot;:[            \&quot;v1\&quot;,            \&quot;v2\&quot;        ]    },    \&quot;toAppVersion\&quot;:\&quot;v3\&quot;,    \&quot;descrip\&quot;:\&quot;xxx\&quot;,    \&quot;workload\&quot;:[        {            \&quot;name\&quot;:\&quot;nginx\&quot;,            \&quot;podSpec\&quot;:{            }        }    ],    \&quot;upgradeStrategy\&quot;:{        \&quot;name\&quot;:\&quot;ScheduleToISP\&quot;,        \&quot;parameters\&quot;:{            \&quot;operator\&quot;:\&quot;In\&quot;,            \&quot;values\&quot;:[                \&quot;telecom\&quot;            ]        }    },    \&quot;autoUpgradeStrategy\&quot;:{        \&quot;name\&quot;:\&quot;AdjustToPodUsage\&quot;,        \&quot;checkInterval\&quot;:600,        \&quot;startTime\&quot;:\&quot;2021-02-19 00:00:00\&quot;,        \&quot;startHourPoint\&quot;:\&quot;0\&quot;,        \&quot;endHourPoint\&quot;:\&quot;8\&quot;,        \&quot;endTime\&quot;:\&quot;2021-02-19 08:00:00\&quot;,        \&quot;level\&quot;:\&quot;RegionId\&quot;,        \&quot;rules\&quot;:[            {                \&quot;regionCodes\&quot;:[                    \&quot;cn-wuxi-telecom_unicom_cmcc\&quot;,                    \&quot;cn-shijiazhuang-telecom_unicom_cmcc\&quot;                ],                \&quot;usageRatioLimit\&quot;:{                    \&quot;maxPodUsageRatio\&quot;:50                },                \&quot;maxUpgradingRatio\&quot;:50            },            {                \&quot;regionCodes\&quot;:[                    \&quot;cn-wuhan-telecom_unicom_cmcc\&quot;                ],                \&quot;usageRatioLimit\&quot;:{                    \&quot;maxPodUsageRatio\&quot;:30                },                \&quot;maxUpgradingRatio\&quot;:20            },            {                \&quot;regionCodes\&quot;:[                    \&quot;All\&quot;                ],                \&quot;usageRatioLimit\&quot;:{                    \&quot;maxPodUsageRatio\&quot;:20                },                \&quot;maxUpgradingRatio\&quot;:50,                \&quot;maxUpgradingCount\&quot;:2            }        ]    }}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The timeout period for asynchronous upgrade. Unit: seconds. Default value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
