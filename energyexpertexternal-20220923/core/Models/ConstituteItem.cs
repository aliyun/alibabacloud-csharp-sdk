// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ConstituteItem : TeaModel {
        /// <summary>
        /// <para>Carbon emission</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.222</para>
        /// </summary>
        [NameInMap("carbonEmissionData")]
        [Validation(Required=false)]
        public double? CarbonEmissionData { get; set; }

        /// <summary>
        /// <para>Data Unit</para>
        /// 
        /// <b>Example:</b>
        /// <para>kWh</para>
        /// </summary>
        [NameInMap("dataUnit")]
        [Validation(Required=false)]
        public string DataUnit { get; set; }

        /// <summary>
        /// <para>Emission source</para>
        /// 
        /// <b>Example:</b>
        /// <para>GEC</para>
        /// </summary>
        [NameInMap("emissionSource")]
        [Validation(Required=false)]
        public string EmissionSource { get; set; }

        /// <summary>
        /// <para>Unique identification of emission source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>carbonInventory.check.by_electricity_properties/carbonInventory.check.wind_electricity/carbonInventory.check.gec</para>
        /// </summary>
        [NameInMap("emissionSourceKey")]
        [Validation(Required=false)]
        public string EmissionSourceKey { get; set; }

        /// <summary>
        /// <para>The name of enterprise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseA</para>
        /// </summary>
        [NameInMap("enterpriseName")]
        [Validation(Required=false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// <para>Gas Emissions Detail List.</para>
        /// </summary>
        [NameInMap("envGasEmissions")]
        [Validation(Required=false)]
        public List<ConstituteItemEnvGasEmissions> EnvGasEmissions { get; set; }
        public class ConstituteItemEnvGasEmissions : TeaModel {
            /// <summary>
            /// <para>Carbon emissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2</para>
            /// </summary>
            [NameInMap("carbonEmissionData")]
            [Validation(Required=false)]
            public double? CarbonEmissionData { get; set; }

            /// <summary>
            /// <para>Gas emissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.33</para>
            /// </summary>
            [NameInMap("gasEmissionData")]
            [Validation(Required=false)]
            public double? GasEmissionData { get; set; }

            /// <summary>
            /// <para>Name of gas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CO₂</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A unique key that identifies the gas type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scope 1: Direct GHG emissions</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>carbonInventory.check.indirect_emissions_from_imported_electricity</para>
        /// </summary>
        [NameInMap("nameKey")]
        [Validation(Required=false)]
        public string NameKey { get; set; }

        /// <summary>
        /// <para>Ratio.example value: 0.5 (i. e. 50%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("ratio")]
        [Validation(Required=false)]
        public double? Ratio { get; set; }

        /// <summary>
        /// <para>Raw data</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2</para>
        /// </summary>
        [NameInMap("rawData")]
        [Validation(Required=false)]
        public double? RawData { get; set; }

        /// <summary>
        /// <para>The child detail list.</para>
        /// </summary>
        [NameInMap("subConstituteItems")]
        [Validation(Required=false)]
        public List<ConstituteItem> SubConstituteItems { get; set; }

    }

}
