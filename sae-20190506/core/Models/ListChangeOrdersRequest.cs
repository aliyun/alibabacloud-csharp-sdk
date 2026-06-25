// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListChangeOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145341c-9708-4967-b3ec-24933767****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The status of the change order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Preparing.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: In progress.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Stopped.</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: Paused for manual confirmation.</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: Paused for automatic confirmation.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Failed due to a system exception.</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: Pending approval.</para>
        /// </description></item>
        /// <item><description><para><b>12</b>: Approved and pending execution.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><para><b>CoBindSlb</b>: Attach an SLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>CoUnbindSlb</b>: Detach an SLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>CoCreateApp</b>: Create an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoDeleteApp</b>: Delete an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoDeploy</b>: Deploy an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoRestartApplication</b>: Restart an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoRollback</b>: Roll back an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoScaleIn</b>: Scale in an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoScaleOut</b>: Scale out an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoStartApplication</b>: Start an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoStopApplication</b>: Stop an application.</para>
        /// </description></item>
        /// <item><description><para><b>CoRescaleApplicationVertically</b>: Change the instance type.</para>
        /// </description></item>
        /// <item><description><para><b>CoDeployHistroy</b>: Roll back to a previous version.</para>
        /// </description></item>
        /// <item><description><para><b>CoBindNas</b>: Attach a NAS file system.</para>
        /// </description></item>
        /// <item><description><para><b>CoUnbindNas</b>: Detach a NAS file system.</para>
        /// </description></item>
        /// <item><description><para><b>CoBatchStartApplication</b>: Batch start applications.</para>
        /// </description></item>
        /// <item><description><para><b>CoBatchStopApplication</b>: Batch stop applications.</para>
        /// </description></item>
        /// <item><description><para><b>CoRestartInstances</b>: Restart instances.</para>
        /// </description></item>
        /// <item><description><para><b>CoDeleteInstances</b>: Delete instances.</para>
        /// </description></item>
        /// <item><description><para><b>CoScaleInAppWithInstances</b>: Scale in an application by specifying instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CoCreateApp</para>
        /// </summary>
        [NameInMap("CoType")]
        [Validation(Required=false)]
        public string CoType { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search of change order descriptions. The operation returns only the change orders whose descriptions contain the <b>keyword</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort order for the field specified by the <b>OrderBy</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The results are sorted in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The results are sorted in descending order.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

    }

}
