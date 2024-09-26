// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCalcEnginesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the compute engine. The value of this parameter is not case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ODPS</b></description></item>
        /// <item><description><b>EMR</b></description></item>
        /// <item><description><b>BLINK</b></description></item>
        /// <item><description><b>HOLO</b></description></item>
        /// <item><description><b>MaxGraph</b></description></item>
        /// <item><description><b>HYBRIDDB_FOR_POSTGRESQL</b></description></item>
        /// <item><description><b>ADB_MYSQL</b></description></item>
        /// <item><description><b>HADOOP_CDH</b></description></item>
        /// <item><description><b>CLICKHOUSE</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS</para>
        /// </summary>
        [NameInMap("CalcEngineType")]
        [Validation(Required=false)]
        public string CalcEngineType { get; set; }

        /// <summary>
        /// <para>The environment in which the compute engine is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DEV</b></description></item>
        /// <item><description><b>PRD</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRD</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The name of the compute engine, which must be exactly matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace with which the compute engine is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
