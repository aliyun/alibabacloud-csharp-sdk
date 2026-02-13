// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class OrgEmission : TeaModel {
        /// <summary>
        /// <para>Carbon Equivalent</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2</para>
        /// </summary>
        [NameInMap("carbonEmissionData")]
        [Validation(Required=false)]
        public double? CarbonEmissionData { get; set; }

        /// <summary>
        /// <para>Sub-module carbon emission data</para>
        /// </summary>
        [NameInMap("moduleEmissionList")]
        [Validation(Required=false)]
        public List<OrgEmissionModuleEmissionList> ModuleEmissionList { get; set; }
        public class OrgEmissionModuleEmissionList : TeaModel {
            /// <summary>
            /// <para>Carbon emissions</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2</para>
            /// </summary>
            [NameInMap("carbonEmissionData")]
            [Validation(Required=false)]
            public double? CarbonEmissionData { get; set; }

            /// <summary>
            /// <para>module name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scope 1: Direct GHG emissions</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Module key</para>
            /// 
            /// <b>Example:</b>
            /// <para>carbonInventory.check.scope_1_direct_ghg_emissions</para>
            /// </summary>
            [NameInMap("nameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

            /// <summary>
            /// <para>Proportion of carbon emissions</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("ratio")]
            [Validation(Required=false)]
            public double? Ratio { get; set; }

        }

        /// <summary>
        /// <para>The name of the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseZ</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Enterprise type</para>
        /// 
        /// <b>Example:</b>
        /// <para>Z-20240115-4</para>
        /// </summary>
        [NameInMap("nameKey")]
        [Validation(Required=false)]
        public string NameKey { get; set; }

        /// <summary>
        /// <para>Proportion of carbon emissions</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.2</para>
        /// </summary>
        [NameInMap("ratio")]
        [Validation(Required=false)]
        public double? Ratio { get; set; }

        /// <summary>
        /// <para>Sub-level data, that is, site data under the organization</para>
        /// </summary>
        [NameInMap("subEmissionItems")]
        [Validation(Required=false)]
        public List<OrgEmission> SubEmissionItems { get; set; }

        /// <summary>
        /// <para>Calculate carbon emissions by share ratio</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.3</para>
        /// </summary>
        [NameInMap("weightingCarbonEmissionData")]
        [Validation(Required=false)]
        public double? WeightingCarbonEmissionData { get; set; }

        /// <summary>
        /// <para>Weight ratio</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.3</para>
        /// </summary>
        [NameInMap("weightingProportion")]
        [Validation(Required=false)]
        public double? WeightingProportion { get; set; }

        /// <summary>
        /// <para>Share ratio Carbon emissions YoY</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4</para>
        /// </summary>
        [NameInMap("weightingRatio")]
        [Validation(Required=false)]
        public double? WeightingRatio { get; set; }

    }

}
