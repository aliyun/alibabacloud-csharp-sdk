// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class BrowseFilesRequest : TeaModel {
        /// <summary>
        /// <para>The absolute path of the directory. Specify <c>/</c> to browse the root directory of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/</para>
        /// </summary>
        [NameInMap("AbsolutePath")]
        [Validation(Required=false)]
        public string AbsolutePath { get; set; }

        /// <summary>
        /// <para>The backup client ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-000***o48</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The Cloud Backup edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>STANDARD</b>: Standard Edition. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>BASIC</b>: Basic Edition. Only ECS file backup is supported in Basic Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per request.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is required to retrieve the next page of results. If this parameter is not specified, the first page of results is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ***Q==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Deprecated. Use MaxResults and NextToken for pagination instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Deprecated. Use MaxResults and NextToken for pagination instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The hash value of the directory. If this parameter is not specified, the root directory of the backup is browsed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef6***46a</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-000***oy9</para>
        /// </summary>
        [NameInMap("RestoreId")]
        [Validation(Required=false)]
        public string RestoreId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The hash value of the backup snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>971***e9d</para>
        /// </summary>
        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        /// <summary>
        /// <para>The storage class of the backup data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>STANDARD</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>ARCHIVE</b>: Archive.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// <para>Deprecated. Do not use.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The backup vault ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-000***jtz</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
