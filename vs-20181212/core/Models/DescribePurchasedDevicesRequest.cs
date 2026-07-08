// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribePurchasedDevicesRequest : TeaModel {
        /// <summary>
        /// <para>Queries by the ID of the group to which the device belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****174-cn-qingdao</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Queries by device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4070*****1132-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Queries by device name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx路口摄像头</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort by. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>id (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sorting order. The default is ascending. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc (ascending)</para>
        /// </description></item>
        /// <item><description><para>desc (descending)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortDirection")]
        [Validation(Required=false)]
        public string SortDirection { get; set; }

        /// <summary>
        /// <para>Queries by device subtype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>bullet (bullet camera)</para>
        /// </description></item>
        /// <item><description><para>dome (dome camera)</para>
        /// </description></item>
        /// <item><description><para>ptz (PTZ camera)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dome</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>Queries by device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ipc (camera)</para>
        /// </description></item>
        /// <item><description><para>platform (platform)</para>
        /// </description></item>
        /// <item><description><para>ied (intelligent edge device)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipc</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Queries by device vendor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公司A</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
