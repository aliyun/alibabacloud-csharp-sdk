// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ListAsyncTasksRequest : TeaModel {
        /// <summary>
        /// <para>The trial data ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231</para>
        /// </summary>
        [NameInMap("dataId")]
        [Validation(Required=false)]
        public int? DataId { get; set; }

        /// <summary>
        /// <para>Specifies whether to validate the request parameters without performing the actual operation. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The service type.</para>
        /// <list type="bullet">
        /// <item><description>document-analyze.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>document-analyze</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
