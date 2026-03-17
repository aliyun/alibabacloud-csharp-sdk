// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateSmartAccessGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether you already have an SAG device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AlreadyHaveSag")]
        [Validation(Required=false)]
        public bool? AlreadyHaveSag { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-payment for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <para>If you set the parameter to false, go to Billing Management to complete the payment after you call this operation. After you complete the payment, the instance can be created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The remarks left by the buyer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remarks</para>
        /// </summary>
        [NameInMap("BuyerMessage")]
        [Validation(Required=false)]
        public string BuyerMessage { get; set; }

        /// <summary>
        /// <para>The edition of SAG when you create an SAG vCPE instance.</para>
        /// <para>Set the value to <b>basic</b>, which specifies Basic Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("CPEVersion")]
        [Validation(Required=false)]
        public string CPEVersion { get; set; }

        /// <summary>
        /// <para>The billing method of the SAG instance.</para>
        /// <para>Set the value to <b>PREPAY</b>, which specifies the subscription billing method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The description of the SAG instance.</para>
        /// <para>The description must be 2 to 256 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The deployment mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>no_backup</b>: You buy only one SAG device to connect private networks to Alibaba Cloud.</description></item>
        /// <item><description><b>cold_backup</b>: You buy two SAG devices in active-standby mode. One SAG device serves as an active device and the other serves as a standby device. Only the active device is connected to Alibaba Cloud. If the active device is not working as expected, you must manually perform a switchover.</description></item>
        /// <item><description><b>warm_backup</b>: You buy two SAG devices in active-active mode. Both SAG devices are connected to Alibaba Cloud. If an active device is not working as expected, a failover is automatically performed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want to create an SAG vCPE instance, set the value to <b>warm_backup</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no_backup</para>
        /// </summary>
        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        /// <summary>
        /// <para>The type of the SAG instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sag-100wm</b></description></item>
        /// <item><description><b>sag-1000</b></description></item>
        /// <item><description><b>sag-vcpe</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-100wm</para>
        /// </summary>
        [NameInMap("HardWareSpec")]
        [Validation(Required=false)]
        public string HardWareSpec { get; set; }

        /// <summary>
        /// <para>The bandwidth of the SAG instance.</para>
        /// <list type="bullet">
        /// <item><description>If you want to create an SAG CPE instance and the model is <b>sag-100wm</b>, valid values of this parameter are <b>2</b> to <b>50</b>. Unit: Mbit/s.</description></item>
        /// <item><description>If you want to create an SAG CPE instance and the model is <b>sag-1000</b>, valid values of this parameter are <b>10</b> to <b>500</b>. Unit: Mbit/s.</description></item>
        /// <item><description>If you want to create an SAG vCPE instance, valid values of this parameter are <b>10</b> to <b>1000</b>. Unit: Mbit/s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MaxBandWidth")]
        [Validation(Required=false)]
        public int? MaxBandWidth { get; set; }

        /// <summary>
        /// <para>The name of the SAG instance.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription period of the SAG instance. Unit: months.</para>
        /// <para>Valid values: <b>1</b> to <b>9</b>, <b>12</b>, <b>24</b>, and <b>36</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The detailed address of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No.XX</para>
        /// </summary>
        [NameInMap("ReceiverAddress")]
        [Validation(Required=false)]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// <para>The city of the recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("ReceiverCity")]
        [Validation(Required=false)]
        public string ReceiverCity { get; set; }

        /// <summary>
        /// <para>The country of the recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("ReceiverCountry")]
        [Validation(Required=false)]
        public string ReceiverCountry { get; set; }

        /// <summary>
        /// <para>The district of the recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>West Lake</para>
        /// </summary>
        [NameInMap("ReceiverDistrict")]
        [Validation(Required=false)]
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// <para>The email address of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xx@example.com">xx@example.com</a></para>
        /// </summary>
        [NameInMap("ReceiverEmail")]
        [Validation(Required=false)]
        public string ReceiverEmail { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1884085****</para>
        /// </summary>
        [NameInMap("ReceiverMobile")]
        [Validation(Required=false)]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// <para>The name of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("ReceiverName")]
        [Validation(Required=false)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// <para>The landline phone number of the recipient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8585****</para>
        /// </summary>
        [NameInMap("ReceiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// <para>The province of the recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("ReceiverState")]
        [Validation(Required=false)]
        public string ReceiverState { get; set; }

        /// <summary>
        /// <para>The town of the recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhuan Tang</para>
        /// </summary>
        [NameInMap("ReceiverTown")]
        [Validation(Required=false)]
        public string ReceiverTown { get; set; }

        /// <summary>
        /// <para>The postcode of the recipient address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>310000</para>
        /// </summary>
        [NameInMap("ReceiverZip")]
        [Validation(Required=false)]
        public string ReceiverZip { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to deploy the SAG instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
