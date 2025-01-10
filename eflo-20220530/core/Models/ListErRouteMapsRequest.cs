// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListErRouteMapsRequest : TeaModel {
        /// <summary>
        /// <para>Destination CIDR Block</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        /// <summary>
        /// <para>Elastic Router ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-kkopgtne</para>
        /// </summary>
        [NameInMap("ErId")]
        [Validation(Required=false)]
        public string ErId { get; set; }

        /// <summary>
        /// <para>routing policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>er-rmap-uwglhzom</para>
        /// </summary>
        [NameInMap("ErRouteMapId")]
        [Validation(Required=false)]
        public string ErRouteMapId { get; set; }

        /// <summary>
        /// <para>Policy number (default for automatic creation is 3000; The value range of the policy number manually created by the user is 1001-2000)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("ErRouteMapNum")]
        [Validation(Required=false)]
        public int? ErRouteMapNum { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Receive Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-x2lohgpv</para>
        /// </summary>
        [NameInMap("ReceptionInstanceId")]
        [Validation(Required=false)]
        public string ReceptionInstanceId { get; set; }

        /// <summary>
        /// <para>Receive Instance Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd2</para>
        /// </summary>
        [NameInMap("ReceptionInstanceName")]
        [Validation(Required=false)]
        public string ReceptionInstanceName { get; set; }

        /// <summary>
        /// <para>The type of the received instance. Optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPD</b>: Lingjun network segment.</description></item>
        /// <item><description><b>VCC</b>: Lingjun Connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPD</para>
        /// </summary>
        [NameInMap("ReceptionInstanceType")]
        [Validation(Required=false)]
        public string ReceptionInstanceType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzaq3ypaqkdy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Policy behavior; optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>permit</b>: Allow</description></item>
        /// <item><description><b>deny</b>: Rejected</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("RouteMapAction")]
        [Validation(Required=false)]
        public string RouteMapAction { get; set; }

        /// <summary>
        /// <para>Release Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-xsdlg2xb</para>
        /// </summary>
        [NameInMap("TransmissionInstanceId")]
        [Validation(Required=false)]
        public string TransmissionInstanceId { get; set; }

        /// <summary>
        /// <para>Release Instance Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd1</para>
        /// </summary>
        [NameInMap("TransmissionInstanceName")]
        [Validation(Required=false)]
        public string TransmissionInstanceName { get; set; }

        /// <summary>
        /// <para>The type of the published instance. Optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPD</b>: Lingjun network segment.</description></item>
        /// <item><description><b>VCC</b>: Lingjun Connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPD</para>
        /// </summary>
        [NameInMap("TransmissionInstanceType")]
        [Validation(Required=false)]
        public string TransmissionInstanceType { get; set; }

    }

}
