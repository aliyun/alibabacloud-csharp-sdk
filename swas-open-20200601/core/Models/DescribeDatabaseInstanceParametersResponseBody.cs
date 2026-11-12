// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of configuration parameters being synchronized. After you modify and submit parameters, the instance starts to synchronize them. Once synchronization is complete, these parameters are removed from this list.</para>
        /// </summary>
        [NameInMap("ConfigParameters")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstanceParametersResponseBodyConfigParameters> ConfigParameters { get; set; }
        public class DescribeDatabaseInstanceParametersResponseBodyConfigParameters : TeaModel {
            /// <summary>
            /// <para>The value range of the parameter.</para>
            /// <remarks>
            /// <para>The value range varies by parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[1-65535]</para>
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// <para>Indicates whether you can modify the parameter value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: You can modify the parameter value.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: You cannot modify the parameter value.</para>
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
            /// <para>Indicates if the database must be restarted for a parameter modification to take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: A restart is required. To apply changes for a parameter that requires a restart, you must set the <c>ForceRestart</c> parameter to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: A restart is not required.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
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
            /// <remarks>
            /// <para>The value varies by parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The database engine. Currently, only <c>MySQL</c> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>5.7</c>: MySQL 5.7.</para>
        /// </description></item>
        /// <item><description><para><c>8.0</c>: MySQL 8.0.</para>
        /// </description></item>
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
        /// <para>A list of running parameters.</para>
        /// </summary>
        [NameInMap("RunningParameters")]
        [Validation(Required=false)]
        public List<DescribeDatabaseInstanceParametersResponseBodyRunningParameters> RunningParameters { get; set; }
        public class DescribeDatabaseInstanceParametersResponseBodyRunningParameters : TeaModel {
            /// <summary>
            /// <para>The value range of the parameter.</para>
            /// <remarks>
            /// <para>The value range varies by parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[ON|OFF]</para>
            /// </summary>
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            /// <summary>
            /// <para>Indicates whether you can modify the parameter value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: You can modify the parameter value.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: You cannot modify the parameter value.</para>
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
            /// <para>Indicates if the database must be restarted for a parameter modification to take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: A restart is required. To apply changes for a parameter that requires a restart, you must set the <c>ForceRestart</c> parameter to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: A restart is not required.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// <para>The description of the running parameter.</para>
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
            /// <para>The value of the running parameter.</para>
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
