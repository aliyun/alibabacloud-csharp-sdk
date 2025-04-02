// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCertificatesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user who created the certificate files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107550004253538</para>
        /// </summary>
        [NameInMap("CreateUser")]
        [Validation(Required=false)]
        public string CreateUser { get; set; }

        /// <summary>
        /// <para>The time when the certificate file was created. You can call this operation to query the files that are created before the time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593877765000</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// <para>The name of the certificate file. Fuzzy match by file name is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_create_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the certificate files. Valid values: Desc: descending order ASC: ascending order Default value: Asc</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the certificate file belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The field used to sort the certificate files. Valid values: CreateTime Id Name Default value: Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The time when the certificate file was created. You can call this operation to query the files that are created after the time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730217600000</para>
        /// </summary>
        [NameInMap("StartCreateTime")]
        [Validation(Required=false)]
        public long? StartCreateTime { get; set; }

    }

}
