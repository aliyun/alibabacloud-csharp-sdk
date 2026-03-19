// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupGatewayListRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. This prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the backup gateway. You can query multiple gateways by separating the identifiers with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>7213527653217</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 0 and cannot exceed the maximum value of an integer. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of records on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the DBS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China (Shanghai)</para>
        /// </description></item>
        /// <item><description><para><b>cn-qingdao</b>: China (Qingdao)</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing</b>: China (Beijing)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Singapore</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-finance</b>: Hangzhou Finance Cloud</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-finance</b>: Shanghai Finance Cloud</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen-finance</b>: Shenzhen Finance Cloud</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
