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
        /// <para>The value must be 1 to 300 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Slow SQL from offline synchronization. No optimization needed.</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: RDS MySQL</description></item>
        /// <item><description><b>PolarDBMySQL</b>: PolarDB for MySQL</description></item>
        /// <item><description><b>PostgreSQL</b>: RDS PostgreSQL</description></item>
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
        /// <para>The SQL template ID. You can call the <a href="https://help.aliyun.com/document_detail/405261.html">GetQueryOptimizeDataStats</a> operation to query SQL template IDs. You can specify multiple template IDs separated by commas (,) to add tags in batches.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6068ce044e3dc9b903979672fb0b69df,d12515c015fc9f41a0778a9e1de0****</para>
        /// </summary>
        [NameInMap("SqlIds")]
        [Validation(Required=false)]
        public string SqlIds { get; set; }

        /// <summary>
        /// <para>The status of the <b>Tags</b> request parameter.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Clears all tags for the SQL template IDs specified by <b>SqlIds</b> and ignores the <b>Tags</b> parameter.</description></item>
        /// <item><description><b>1</b>: Sets the tags for the SQL template IDs specified by <b>SqlIds</b> to the values specified by <b>Tags</b>.</description></item>
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
        /// <para>The SQL tag. You can specify multiple values separated by commas (,).</para>
        /// <list type="bullet">
        /// <item><description><b>DAS_IMPORTANT</b>: important SQL.</description></item>
        /// <item><description><b>DAS_NOT_IMPORTANT</b>: unimportant SQL.</description></item>
        /// <item><description><b>USER_IGNORE</b>: optimization not required.</description></item>
        /// <item><description><b>DAS_IN_PLAN</b>: scheduled for optimization.</description></item>
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
