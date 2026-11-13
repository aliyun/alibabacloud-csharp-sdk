// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteTableRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the MaxCompute project. Format: odps.{projectName}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.test</para>
        /// </summary>
        [NameInMap("AppGuid")]
        [Validation(Required=false)]
        public string AppGuid { get; set; }

        /// <summary>
        /// <para>The type of the engine or data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cdh</description></item>
        /// <item><description>analyticdb_for_mysql</description></item>
        /// <item><description>odps</description></item>
        /// <item><description>emr</description></item>
        /// <item><description>hadoop</description></item>
        /// <item><description>holodb</description></item>
        /// <item><description>hybriddb_for_postgresql</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The schema information of the table. In ODPS, you must specify the schema information when the three-tier model is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table1</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
