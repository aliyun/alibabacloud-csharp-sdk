// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckInstanceResultRequest : TeaModel {
        /// <summary>
        /// <para>The check item ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The instance ID of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf64w4q6p9jti5gl****</para>
        /// </summary>
        [NameInMap("InstanceIdKey")]
        [Validation(Required=false)]
        public string InstanceIdKey { get; set; }

        /// <summary>
        /// <para>The collection of cloud service instance IDs to query.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The instance name of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf64w4q6p9jti5gl****</para>
        /// </summary>
        [NameInMap("InstanceNameKey")]
        [Validation(Required=false)]
        public string InstanceNameKey { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Maximum value: 100. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionIdKey")]
        [Validation(Required=false)]
        public string RegionIdKey { get; set; }

        /// <summary>
        /// <para>The list of sort types for the check item.</para>
        /// </summary>
        [NameInMap("SortTypes")]
        [Validation(Required=false)]
        public List<string> SortTypes { get; set; }

        /// <summary>
        /// <para>The collection of check item statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
