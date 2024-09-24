// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetImportantRequest : TeaModel {
        /// <summary>
        /// <para>The importance of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: test</description></item>
        /// <item><description><b>1</b>: normal</description></item>
        /// <item><description><b>2</b>: important</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ImportantCode")]
        [Validation(Required=false)]
        public int? ImportantCode { get; set; }

        /// <summary>
        /// <para>The UUIDs of servers. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>076a446d-df7d-424c-bdc5-bb5dc7f1****</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
