// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The MartketInstance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>786***45</para>
        /// </summary>
        [NameInMap("MarketInstanceId")]
        [Validation(Required=false)]
        public string MarketInstanceId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2306175xxxxxxxx</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The status of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Created</b></description></item>
        /// <item><description><b>Deploying</b></description></item>
        /// <item><description><b>DeployedFailed</b></description></item>
        /// <item><description><b>Deployed</b></description></item>
        /// <item><description><b>Upgrading</b></description></item>
        /// <item><description><b>Deleting</b></description></item>
        /// <item><description><b>Deleted</b></description></item>
        /// <item><description><b>DeletedFailed</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
