// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectTaskDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ticket. You can call the <a href="https://help.aliyun.com/document_detail/208388.html">CreateDataCorrectOrder</a>, <a href="https://help.aliyun.com/document_detail/208387.html">CreateDataImportOrder</a>, or <a href="https://help.aliyun.com/document_detail/208386.html">CreateFreeLockCorrectOrder</a> operation to obtain the ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12435523</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>: To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the &quot;View information about the current tenant&quot; section of the <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a> topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14325432</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
