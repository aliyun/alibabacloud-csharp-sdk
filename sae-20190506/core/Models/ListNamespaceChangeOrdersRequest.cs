// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespaceChangeOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The change order status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Preparing.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Executing.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Terminated.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: System Error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CoStatus")]
        [Validation(Required=false)]
        public string CoStatus { get; set; }

        /// <summary>
        /// <para>The change order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CoBatchStartApplication</b>: Batch Start Application.</para>
        /// </description></item>
        /// <item><description><para><b>CoBatchStopApplication</b>: Batch Stop Application.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CoBatchStartApplication</para>
        /// </summary>
        [NameInMap("CoType")]
        [Validation(Required=false)]
        public string CoType { get; set; }

        /// <summary>
        /// <para>The current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A keyword for a fuzzy search of change order descriptions. Change orders whose descriptions contain this <b>key</b> are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
