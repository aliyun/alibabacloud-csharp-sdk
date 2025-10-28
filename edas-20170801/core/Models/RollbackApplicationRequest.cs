// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class RollbackApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/423162.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-4f92-4413-************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The number of batches for the rollback. Default value: 1. Valid values: 1 to 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public int? Batch { get; set; }

        /// <summary>
        /// <para>The wait time between batches. Default value: 0. The default value indicates no wait time. Valid values: 0 to 5. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The application group ID. You can call the ListDeployGroup operation to query the application group ID. For more information, see <a href="https://help.aliyun.com/document_detail/423184.html">ListDeployGroup</a>.</para>
        /// <para>If you need to roll back the application in all application groups, set this parameter to <c>all</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8123db90-880f-48***************</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The historical version to which you want to roll back the application. Call the ListHistoryDeployVersion operation to query the historical versions of the application. Then, set this parameter based on the returned value of <c>PackageVersion</c>. For more information, see <a href="https://help.aliyun.com/document_detail/423163.html">ListHistoryDeployVersion</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-13 14:22:22</para>
        /// </summary>
        [NameInMap("HistoryVersion")]
        [Validation(Required=false)]
        public string HistoryVersion { get; set; }

    }

}
