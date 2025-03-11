// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetupDrdsParamsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SetupDrdsParamsRequestData> Data { get; set; }
        public class SetupDrdsParamsRequestData : TeaModel {
            /// <summary>
            /// <para>The name of the parameter that you want to configure for a database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The valid values of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[true|false]</para>
            /// </summary>
            [NameInMap("ParamRanges")]
            [Validation(Required=false)]
            public string ParamRanges { get; set; }

            /// <summary>
            /// <para>The type of the parameter that you want to configure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ATOM</b>: the configuration item in the layer-3 data source.</description></item>
            /// <item><description><b>CONFIG</b>: the configuration item in ConfigServer.</description></item>
            /// <item><description><b>DIAMOND</b>: the configuration item in Diamond.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ATOM</para>
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// <para>The value of parameter that you want to configure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            /// <summary>
            /// <para>The name of the parameter that you want to configure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FORBID_EXECUTE_DML_ALL</para>
            /// </summary>
            [NameInMap("ParamVariableName")]
            [Validation(Required=false)]
            public string ParamVariableName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance for which you want to configure parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drdsjiii1b49****</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The resource for which you want to configure parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b>: Configure parameters for the instance.</description></item>
        /// <item><description><b>DB</b>: Configure parameters for the databases of the instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB</para>
        /// </summary>
        [NameInMap("ParamLevel")]
        [Validation(Required=false)]
        public string ParamLevel { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the PolarDB-X 1.0 instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
