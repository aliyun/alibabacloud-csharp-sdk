// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataLakeCatalogResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data catalog.</para>
        /// </summary>
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public DLCatalog Catalog { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Error message returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code: 404, can not find catalog, name : hiv request id: 6090E571-E5B1-1E6D-BF44-F9E10E8B****</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request, used for log tracing and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE8EE2F1-4880-46BC-A704-5CF63EAF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
