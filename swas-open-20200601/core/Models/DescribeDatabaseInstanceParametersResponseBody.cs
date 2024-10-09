// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The range of ParameterValue.</para>
        /// <remarks>
        /// <para>The value of CheckingCode varies based on the value of ParameterName.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstanceParametersResponseBodyConfigParameters> ConfigParameters { get; set; }
        public class DescribeDatabaseInstanceParametersResponseBodyConfigParameters : TeaModel {
            /// <summary>
            /// <para>The check code that indicates the valid values of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[1-65535]</para>
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// <para>Does it support modifying parameter values. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>true:Support modifying parameter values.</para>
            /// </description></item>
            /// <item><description><para>false:Modifying parameter values is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ForceModify")]
            [Validation(Required=false)]
            public string ForceModify { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly restart the instance after parameters are modified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: forcibly restarts the instance. If a new parameter value takes effect only after the instance restarts, you must set this parameter to true. Otherwise, the new parameter value cannot take effect.</description></item>
            /// <item><description>false: does not forcibly restart the instance.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// <para>The description of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Auto-increment columns are incremented by this</para>
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_increment_increment</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The database engine that the instance runs. The value must be MySQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5.7: MySQL 5.7.</description></item>
        /// <item><description>8.0: MySQL 8.0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.5</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The range of ParameterValue.</para>
        /// <remarks>
        /// <para>The value of CheckingCode varies based on the value of ParameterName.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstanceParametersResponseBodyRunningParameters> RunningParameters { get; set; }
        public class DescribeDatabaseInstanceParametersResponseBodyRunningParameters : TeaModel {
            /// <summary>
            /// <para>The check code that indicates the valid values of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[ON|OFF]</para>
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// <para>Does it support modifying parameter values. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>true:Support modifying parameter values.</para>
            /// </description></item>
            /// <item><description><para>false:Modifying parameter values is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ForceModify")]
            [Validation(Required=false)]
            public string ForceModify { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly restart the instance after parameters are modified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: forcibly restarts the instance. If a new parameter value takes effect only after the instance restarts, you must set this parameter to true. Otherwise, the new parameter value cannot take effect.</description></item>
            /// <item><description>false: does not forcibly restart the instance.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// <para>The description of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>When this variable has a value of 1 (the default), the server automatically grants the EXECUTE and ALTER ROUTINE privileges to the creator of a stored routine, if the user cannot already execute and alter or drop the routine. (The ALTER ROUTINE privilege is required to drop the routine.) The server also automatically drops those privileges from the creator when the routine is dropped. If automatic_sp_privileges is 0, the server does not automatically add or drop these privileges.</para>
            /// </summary>
            [NameInMap("ParameterDescription")]
            [Validation(Required=false)]
            public string ParameterDescription { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autocommit</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

    }

}
