// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescibeImportsFromDatabaseResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescibeImportsFromDatabaseResponseBodyItems Items { get; set; }
        public class DescibeImportsFromDatabaseResponseBodyItems : TeaModel {
            [NameInMap("ImportResultFromDB")]
            [Validation(Required=false)]
            public List<DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB> ImportResultFromDB { get; set; }
            public class DescibeImportsFromDatabaseResponseBodyItemsImportResultFromDB : TeaModel {
                [NameInMap("ImportDataStatus")]
                [Validation(Required=false)]
                public string ImportDataStatus { get; set; }

                [NameInMap("ImportDataStatusDescription")]
                [Validation(Required=false)]
                public string ImportDataStatusDescription { get; set; }

                [NameInMap("ImportDataType")]
                [Validation(Required=false)]
                public string ImportDataType { get; set; }

                [NameInMap("ImportId")]
                [Validation(Required=false)]
                public int? ImportId { get; set; }

                [NameInMap("IncrementalImportingTime")]
                [Validation(Required=false)]
                public string IncrementalImportingTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B000AA91-393D-46F9-8D9B-098E28931A3A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
