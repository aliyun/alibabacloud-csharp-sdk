// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateQueryOptimizeTagRequest : TeaModel {
        /// <summary>
        /// <para>The remarks.</para>
        /// <para>The remarks can be 1 to 300 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Slow SQL queries of offline synchronization. No optimization is required.</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL</description></item>
        /// <item><description><b>PolarDBMySQL</b>: PolarDB for MySQL</description></item>
        /// <item><description><b>PostgreSQL</b>: ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The SQL template IDs. You can call the <a href="https://help.aliyun.com/document_detail/405261.html">GetQueryOptimizeExecErrorStats</a> operation to obtain the SQL template ID. Separate multiple SQL template IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6068ce044e3dc9b903979672fb0b69df,d12515c015fc9f41a0778a9e1de0e941</para>
        /// </summary>
        [NameInMap("SqlIds")]
        [Validation(Required=false)]
        public string SqlIds { get; set; }

        /// <summary>
        /// <para>The status of <b>Tags</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: removes all tags added to the SQL templates that are specified by <b>SqlIds</b> and leaves <b>Tags</b> empty.</description></item>
        /// <item><description><b>1</b>: adds the tags specified by <b>Tags</b> to the SQL templates that are specified by <b>SqlIds</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The SQL tags. Separate multiple SQL tags with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DAS_IMPORTANT</b>: The SQL template is important.</description></item>
        /// <item><description><b>DAS_NOT_IMPORTANT</b>: The SQL template is unimportant.</description></item>
        /// <item><description><b>USER_IGNORE</b>: The scheduling of the SQL template does not need to be optimized.</description></item>
        /// <item><description><b>DAS_IN_PLAN</b>: The scheduling of the SQL template needs to be optimized.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAS_IN_PLAN,DAS_NOT_IMPORTANT</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
