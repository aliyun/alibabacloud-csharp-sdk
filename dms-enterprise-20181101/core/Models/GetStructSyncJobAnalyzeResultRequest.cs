// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobAnalyzeResultRequest : TeaModel {
        /// <summary>
        /// <para>The type of the comparison. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATE_TABLE</b>: compares the created tables.</description></item>
        /// <item><description><b>ALTER_TABLE</b>: compares the modified tables.</description></item>
        /// <item><description><b>EQUAL_TABLE</b>: compares the identical tables.</description></item>
        /// <item><description><b>PASS_TABLE</b>: compares the tables that are skipped during schema synchronization.</description></item>
        /// <item><description><b>NOT_COMPARE</b>: does not compare tables.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_TABLE</para>
        /// </summary>
        [NameInMap("CompareType")]
        [Validation(Required=false)]
        public string CompareType { get; set; }

        /// <summary>
        /// <para>The ID of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1342355</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
