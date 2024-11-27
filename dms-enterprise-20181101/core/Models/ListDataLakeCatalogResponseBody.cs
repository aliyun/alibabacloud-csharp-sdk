// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataLakeCatalogResponseBody : TeaModel {
        [NameInMap("CataLogList")]
        [Validation(Required=false)]
        public ListDataLakeCatalogResponseBodyCataLogList CataLogList { get; set; }
        public class ListDataLakeCatalogResponseBodyCataLogList : TeaModel {
            [NameInMap("Catalog")]
            [Validation(Required=false)]
            public List<DLCatalog> Catalog { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E76DD2E7-EBAC-5724-B163-19AAC233F8F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
