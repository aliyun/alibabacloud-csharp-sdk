// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetPurchaseControlRecordRequest : TeaModel {
        /// <summary>
        /// <para>The customer UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>292828565558721922</para>
        /// </summary>
        [NameInMap("CustomerUID")]
        [Validation(Required=false)]
        public long? CustomerUID { get; set; }

        /// <summary>
        /// <para>The start time. If left empty, data from the last six months is returned. The time format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-15 10:34:36</para>
        /// </summary>
        [NameInMap("OperationTime")]
        [Validation(Required=false)]
        public string OperationTime { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
