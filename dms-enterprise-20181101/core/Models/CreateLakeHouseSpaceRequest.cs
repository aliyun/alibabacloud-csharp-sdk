// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateLakeHouseSpaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the development database. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2435****</para>
        /// </summary>
        [NameInMap("DevDbId")]
        [Validation(Required=false)]
        public string DevDbId { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>14</b>: AnalyticDB for MySQL</description></item>
        /// <item><description><b>18</b>: AnalyticDB for PostgreSQL</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("DwDbType")]
        [Validation(Required=false)]
        public string DwDbType { get; set; }

        /// <summary>
        /// <para>The mode in which the workspace runs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: basic mode. This mode is unavailable.</description></item>
        /// <item><description><b>1</b>: standard mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The ID of the production database. You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2442****</para>
        /// </summary>
        [NameInMap("ProdDbId")]
        [Validation(Required=false)]
        public string ProdDbId { get; set; }

        /// <summary>
        /// <para>The configuration of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>skipManualRunCheck</b>: No security rule check is required in the trial run phase.</description></item>
        /// <item><description><b>skipPublishApprove</b>: No approval is required for publishing and O\&amp;M.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;skipManualRunCheck\&quot;:true,\&quot;skipPublishApprove\&quot;:true}</para>
        /// </summary>
        [NameInMap("SpaceConfig")]
        [Validation(Required=false)]
        public string SpaceConfig { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_space</para>
        /// </summary>
        [NameInMap("SpaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
