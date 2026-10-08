// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossBackupMetaListRequest : TeaModel {
        /// <summary>
        /// <para>The cross-region backup set ID. You can call the DescribeCrossRegionBackups operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The name of the database to query. Exact match is used. The specific database name and the table names within the database are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb1</para>
        /// </summary>
        [NameInMap("GetDbName")]
        [Validation(Required=false)]
        public string GetDbName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: greater than 0 and up to the maximum value of Integer.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when it is specified together with <b>PageSize</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public string PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when it is specified together with <b>PageIndex</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The name of the database to query. Fuzzy match is used. Only the matched database names are returned, and table names are not returned.</para>
        /// <remarks>
        /// <para>You can use fuzzy match first. For example, pass in test to match testdb1 and testdb2. After you determine the target database name, use exact match by passing in <b>GetDbName</b> to view the specific database name and table names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
