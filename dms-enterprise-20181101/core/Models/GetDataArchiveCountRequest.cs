// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveCountRequest : TeaModel {
        /// <summary>
        /// <para>The type of the identity. Default value: AS_ADMIN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AS_ADMIN</para>
        /// </summary>
        [NameInMap("OrderResultType")]
        [Validation(Required=false)]
        public string OrderResultType { get; set; }

        /// <summary>
        /// <para>The plugin type. Default value: DATA_ARCHIVE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_ARCHIVE</para>
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// <para>The time when the ticket is modified or created. The statistics of data archiving tickets are calculated based on the creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_TIME</para>
        /// </summary>
        [NameInMap("SearchDateType")]
        [Validation(Required=false)]
        public string SearchDateType { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para> To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2****</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
