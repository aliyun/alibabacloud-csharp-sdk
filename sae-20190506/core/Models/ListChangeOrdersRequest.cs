// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListChangeOrdersRequest : TeaModel {
        /// <summary>
        /// <para>1</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145341c-9708-4967-b3ec-24933767****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CoStatus")]
        [Validation(Required=false)]
        public string CoStatus { get; set; }

        /// <summary>
        /// <para>The type of the change order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CoBindSlb</b>: associates the Server Load Balancer (SLB) instance with the application.</description></item>
        /// <item><description><b>CoUnbindSlb</b>: disassociates an SLB instance from the application.</description></item>
        /// <item><description><b>CoCreateApp</b>: creates the application.</description></item>
        /// <item><description><b>CoDeleteApp</b>: deletes the application.</description></item>
        /// <item><description><b>CoDeploy</b>: deploys the application.</description></item>
        /// <item><description><b>CoRestartApplication</b>: restarts the application.</description></item>
        /// <item><description><b>CoRollback</b>: rolls back the application.</description></item>
        /// <item><description><b>CoScaleIn</b>: scales in the application.</description></item>
        /// <item><description><b>CoScaleOut</b>: scales out the application.</description></item>
        /// <item><description><b>CoStartApplication</b>: starts the application.</description></item>
        /// <item><description><b>CoStopApplication</b>: stops the application.</description></item>
        /// <item><description><b>CoRescaleApplicationVertically</b>: modifies the instance type.</description></item>
        /// <item><description><b>CoDeployHistroy</b>: rolls back the application to an earlier version.</description></item>
        /// <item><description><b>CoBindNas</b>: associates a network-attached storage (NAS) file system with the application.</description></item>
        /// <item><description><b>CoUnbindNas</b>: disassociates a NAS file system from the application.</description></item>
        /// <item><description><b>CoBatchStartApplication</b>: starts multiple applications concurrently.</description></item>
        /// <item><description><b>CoBatchStopApplication</b>: stops multiple applications concurrently.</description></item>
        /// <item><description><b>CoRestartInstances</b>: restarts the instance.</description></item>
        /// <item><description><b>CoDeleteInstances</b>: deletes the instance.</description></item>
        /// <item><description><b>CoScaleInAppWithInstances</b>: reduces the specified number of application instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CoCreateApp</para>
        /// </summary>
        [NameInMap("CoType")]
        [Validation(Required=false)]
        public string CoType { get; set; }

        /// <summary>
        /// <para>20</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>CoCreateApp</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>test</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
